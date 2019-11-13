using AutoMapper;
using AutoMapper.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingGarnet;
using HotelBookingGarnet.Models;
using HotelBookingGarnet.Services;
using HotelBookingGarnet.ViewModels;
using HotelBookingGarnetTest.TestUtils;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace HotelBookingGarnetTest.Services
{

    [Collection("Database collection")]
    public class HotelServiceTest
    {
        private readonly DbContextOptions<ApplicationContext> options;
        private readonly Mock<IMapper> mockMapper;
        private readonly Mock<IImageService> mockImageService;
        private readonly Mock<IPropertyTypeService> mockPropertyTypeService;

        public HotelServiceTest()
        {
            this.options = TestDbOptions.Get();
            this.mockMapper = new Mock<IMapper>();
            this.mockImageService = new Mock<IImageService>();
            this.mockPropertyTypeService = new Mock<IPropertyTypeService>();
        }

        [Fact]
        public void GetHotels_ShouldGetAllHotelFromDatabase()
        {
            using (var context = new ApplicationContext(options))
            {
                var hotelService = new HotelService(context, mockPropertyTypeService.Object, mockImageService.Object, mockMapper.Object);

                var expected = hotelService.GetHotels();
                var actual = 1;
                Assert.Equal(expected.Count, actual);
            }
        }

        [Fact]
        public async Task Add_Hotel_Should_Increase_Number_Of_Hotels()
        {
            using (var context = new ApplicationContext(options))
            {
                var hotel = new HotelViewModel
                {
                    HotelName = "Test",
                    Country = "Test",
                    Region = "test",
                    Address = "test",
                    City = "test",
                    Description = "test",
                };

                var hotelService = new HotelService(context, mockPropertyTypeService.Object,
                    mockImageService.Object, mockMapper.Object);

                mockPropertyTypeService.Setup(x => x.AddPropertyTypeAsync(It.IsAny<string>()))
                    .Returns(Task.FromResult(new PropertyType()
                    {
                        PropertyTypeId = 1,
                    }));

                mockMapper.Setup(x => x.Map<HotelViewModel, Hotel>(It.IsAny<HotelViewModel>()))
                    .Returns(new Hotel()
                    {
                        HotelName = hotel.HotelName,
                        Country = hotel.Country,
                        Region = hotel.Region,
                        Address = hotel.Address,
                        City = hotel.City,
                        Description = hotel.Description

                    });
                var length = await context.Hotels.CountAsync();
                var actual = await hotelService.AddHotelAsync(hotel, "123");
                Assert.Equal(length + 1, await context.Hotels.CountAsync());

            }
        }

        [Fact]
        public void AverageRating_ShouldCalculateAverage()
        {
            using (var context = new ApplicationContext(options))
            {
                var hotelService = new HotelService(context, mockPropertyTypeService.Object, mockImageService.Object, 
                    mockMapper.Object);

                List<Review> reviews = new List<Review>();
                reviews.Add(new Review{Rating = 4});
                reviews.Add(new Review{Rating = 2});
                reviews.Add(new Review{Rating = 3});
                
                var actual = hotelService.AverageRating(reviews);
                var expected = 3;
                Assert.Equal(expected, actual);
            }
        }
    }
}
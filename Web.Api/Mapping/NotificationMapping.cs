using AutoMapper;
using OrderSync.DtoLayer.NotificationDto;
using OrderSync.EntityLayer.Entities;

namespace Web.Api.Mapping
{
	public class NotificationMapping : Profile
	{
		public NotificationMapping() 
		{
			CreateMap<Notification, ResultNotificationDto>().ReverseMap();
			CreateMap<Notification, CreateNotificationDto>().ReverseMap();
			CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
		}
	}
}

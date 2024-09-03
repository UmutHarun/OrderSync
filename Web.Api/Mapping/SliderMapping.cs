using AutoMapper;
using OrderSync.DtoLayer.SliderDto;
using OrderSync.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SliderMapping:Profile
	{
        public SliderMapping()
        {
			CreateMap<Slider, ResultSliderDto>().ReverseMap();
		}
    }
}

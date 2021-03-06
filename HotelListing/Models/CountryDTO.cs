using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name must have up to 50 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short country name must have up to 2 characters")]
        public string ShortName { get; set; }
    }

    public class CountryDTO: CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }

    public class UpdateCountryDTO: CreateCountryDTO
    {
        public List<CreateHotelDTO> Hotels { get; set; }
    }
}

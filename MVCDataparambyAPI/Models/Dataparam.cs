using System.ComponentModel.DataAnnotations;

namespace MVCDataparambyAPI.Models
{
    public class Dataparam
    {
            [Required]
            public int did { get; set; }
        [Required]
            public int meterId { get; set; }
        [Required]
            public int dtrid { get; set; }
        [Required]
            public DateTime rtc { get; set; }
        [Required]
            public float currentRphase { get; set; }
        [Required]
            public float currentYphase { get; set; }
        [Required]
            public float currentBphase { get; set; }
        [Required]
            public string? powerAlert { get; set; }
        [Required]
            public string? srlcdoorsStatus { get; set; }
        [Required]
            public string? oilLevel { get; set; }
        [Required]
            public string? srlcoilLevel { get; set; }
        [Required]
            public float srlcoilTemperature { get; set; }
        [Required]
            public float srlcsurfaceTemperature { get; set; }
        [Required]
            public float srlcambtemperature { get; set; }
        [Required]
            public string? relayAlert { get; set; }
        [Required]
            public float l1voltageVrn { get; set; }
        [Required]
            public float l2voltageVyn { get; set; }
        [Required]
            public float l3voltageVbn { get; set; }
        [Required]
            public float frequency { get; set; }
        [Required]
            public bool status { get; set; }
        
    }
}

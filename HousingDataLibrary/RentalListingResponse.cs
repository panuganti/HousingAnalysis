using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HousingDataLibrary
{
    [DataContract]
    public class RentalListingResponse
    {
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string status { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public HouseListing result { get; set; }
    }

    [DataContract]
    public class RentalListing
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public double latitude { get; set; }

        [DataMember]
        public double longitude { get; set; }

        [DataMember]
        public double center_point_latitude { get; set; }

        [DataMember]
        public double center_point_longitude { get; set; }

        [DataMember]
        public string street_info { get; set; }

        [DataMember]
        public string locality { get; set; }

        [DataMember]
        public double rent { get; set; }

        [DataMember]
        public string formatted_rent { get; set; }

        [DataMember]
        public string apartment_type { get; set; }

        [DataMember]
        public string lease_type { get; set; }

        [DataMember]
        public string furnish_type { get; set; }

        [DataMember]
        public string property_type { get; set; }

        [DataMember]
        public double floor_count { get; set; }

        [DataMember]
        public double floor_number { get; set; }

        [DataMember]
        public string thumb_id { get; set; }

        [DataMember]
        public string thumb_name { get; set; }

        [DataMember]
        public string thumb_url { get; set; }

        [DataMember]
        public string thumb_url_new { get; set; }

        [DataMember]
        public double area { get; set; }

        [DataMember]
        public double security_deposit { get; set; }

        [DataMember]
        public double formatted_security_deposit { get; set; }

        [DataMember]
        public double bedroom_count { get; set; }

        [DataMember]
        public double ac_count { get; set; }

        [DataMember]
        public double tv_count { get; set; }

        [DataMember]
        public double bed_count { get; set; }

        [DataMember]
        public double cupboard_count { get; set; }

        [DataMember]
        public bool is_rent_negotiable { get; set; }

        [DataMember]
        public bool is_security_deposit_negotiable { get; set; }

        [DataMember]
        public bool has_microwave { get; set; }

        [DataMember]
        public bool has_refrigerator { get; set; }

        [DataMember]
        public bool has_washing_machine { get; set; }

        [DataMember]
        public bool has_dining_table { get; set; }

        [DataMember]
        public bool has_sofa { get; set; }

        [DataMember]
        public bool has_swimming_pool { get; set; }

        [DataMember]
        public bool has_gym { get; set; }

        [DataMember]
        public bool has_lift { get; set; }

        [DataMember]
        public bool has_parking { get; set; }

        [DataMember]
        public bool has_stove { get; set; }

        [DataMember]
        public bool has_garden { get; set; }

        [DataMember]
        public string main_entrance_facing { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public int image_count { get; set; }

        [DataMember]
        public List<List<string>> images { get; set; }

        [DataMember]
        public List<List<string>> images_new { get; set; }

        [DataMember]
        public List<ImageWithMasterTag> images_with_master_tags { get; set; }

        [DataMember]
        public string share_url { get; set; }

        [DataMember]
        public string canonical_url { get; set; }

        [DataMember]
        public string locality_url_name { get; set; }

        [DataMember]
        public string locality_filter_param { get; set; }

        [DataMember]
        public double fi { get; set; }

        [DataMember]
        public string region_name { get; set; }

        [DataMember]
        public string date_added { get; set; }

        [DataMember]
        public string available_from { get; set; }

        [DataMember]
        public List<string> seo_address_tags { get; set; }

        [DataMember]
        public string seo_title { get; set; }

        [DataMember]
        public List<string> display_regions { get; set; }

        [DataMember]
        public string description { get; set; } // TODO: Double check datatype

        [DataMember]
        public int power_backup_type_id { get; set; }

        [DataMember]
        public int security_type_id { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool is_gated_community { get; set; }

        [DataMember]
        public string status { get; set; }

        [DataMember]
        public int city_id { get; set; }

        [DataMember]
        public bool has_gas_pipeline { get; set; }

        [DataMember]
        public string water_supply_type { get; set; }

        [DataMember]
        public bool has_servant_room { get; set; }

        [DataMember]
        public string power_backup_type { get; set; }

        [DataMember]
        public string formatted_maintenance_charges { get; set; }

        [DataMember]
        public string security_type { get; set; }

        [DataMember]
        public LifeStyle lifestyle_fields { get; set; }

        [DataMember]
        public string lifestyle_rating { get; set; }

        [DataMember]
        public string city_name { get; set; }

        [DataMember]
        public List<Broker> brokers { get; set; } // Check if broker fields are correct

        [DataMember]
        public string owner_type { get; set; }

        [DataMember]
        public List<RentalContactPerson> contact_persons { get; set; }

        [DataMember]
        public string contact_person_type { get; set; }

    }

    [DataContract]
    public class Owner
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public List<string> number { get; set; }
    }

    [DataContract]
    public class RentalContactPerson
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string number { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string original_number { get; set; } // TODO: Check datatype

        [DataMember]
        public string profile_type { get; set; }
    }
}

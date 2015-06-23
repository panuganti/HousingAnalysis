using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HousingDataLibrary
{
    [DataContract]
    public class HouseListingResponse
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
    public class HouseListing
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
        public double price { get; set; }

        [DataMember]
        public string formatted_price { get; set; }

        [DataMember]
        public double per_square_feet_rate { get; set; }

        [DataMember]
        public double floor_count { get; set; }

        [DataMember]
        public double floor_number { get; set; }

        [DataMember]
        public string apartment_type { get; set; }

        [DataMember]
        public string property_type { get; set; }

        [DataMember]
        public string date_added { get; set; }

        [DataMember]
        public string available_from { get; set; }

        [DataMember]
        public double age_of_property { get; set; }

        [DataMember]
        public string age_of_property_date { get; set; }

        [DataMember]
        public string under_construction { get; set; }

        [DataMember]
        public string thumb_id { get; set; }

        [DataMember]
        public string thumb_name { get; set; }

        [DataMember]
        public string thumb_url { get; set; }

        [DataMember]
        public string thumb_url_new { get; set; }

        [DataMember]
        public List<List<string>> floor_plan_images { get; set; }

        [DataMember]
        public List<List<string>> floor_plan_images_new { get; set; }

        [DataMember]
        public double built_up_area { get; set; }

        [DataMember]
        public double bedroom_count { get; set; }

        [DataMember]
        public double bathroom_count { get; set; }

        [DataMember]
        public bool is_price_negotiable { get; set; }

        [DataMember]
        public bool has_swimming_pool { get; set; }

        [DataMember]
        public bool has_gym { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int number_of_lifts { get; set; }

        [DataMember]
        public int parking_count { get; set; }

        [DataMember]
        public List<string> seo_address_tags { get; set; }

        [DataMember]
        public string seo_title { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public List<string> display_regions { get; set; }

        [DataMember]
        public string description { get; set; } // TODO: Double check datatype

        [DataMember]
        public string main_entrance_facing { get; set; }

        [DataMember]
        public string status { get; set; }

        [DataMember]
        public int image_count { get; set; }

        [DataMember]
        public List<List<string>> images { get; set; }

        [DataMember]
        public List<List<string>> images_new { get; set; }

        [DataMember]
        public List<ImageWithMasterTag> images_with_master_tags { get; set; }

        [DataMember]
        public string region_name { get; set; }

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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool is_gated_community { get; set; }

        [DataMember]
        public string security_type { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool is_society_formed { get; set; } // TODO: Double check datatype

        [DataMember]
        public LifeStyle lifestyle_fields { get; set; }

        [DataMember]
        public string lifestyle_rating { get; set; }

        [DataMember]
        public string city_name { get; set; }

        [DataMember]
        public List<Broker> brokers { get; set; }

        [DataMember]
        public string owner_type { get; set; }

        [DataMember]
        public List<ContactPerson> contact_persons { get; set; }

        [DataMember]
        public string contact_person_type { get; set; }
    }

    [DataContract]
    public class ContactPerson
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int profile_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string firm_name { get; set; } // TODO: Check datatype

        [DataMember]
        public string number { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string original_number { get; set; } // TODO: Check datatype

        [DataMember]
        public string profile_url { get; set; }

        [DataMember]
        public string image_url { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string image_url_new { get; set; } // TODO: Check datatype

        [DataMember]
        public string profile_type { get; set; }
    }

    [DataContract]
    public class Broker
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string firm { get; set; } // TODO: determine datatype

        [DataMember]
        public List<string> number { get; set; }

        [DataMember]
        public string experience { get; set; }

        [DataMember]
        public List<Locality> localities { get; set; }

        [DataMember]
        public List<Service> services { get; set; }

        [DataMember]
        public string firm_legal_status { get; set; }

        [DataMember]
        public string image_url { get; set; }

        [DataMember]
        public string image_url_new { get; set; }
    }

    [DataContract]
    public class Service : Locality
    {
    }

    [DataContract]
    public class Locality
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
    }

    [DataContract]
    public class LifeStyle
    {
        [DataMember]
        public double lifestyle_rating { get; set; }

        [DataMember]
        public double society_rating { get; set; }

        [DataMember]
        public double location_rating { get; set; }

        [DataMember]
        public string lifestyle_rating_type { get; set; }

        [DataMember]
        public double connectivity_score { get; set; }

        [DataMember]
        public double location_score { get; set; }

        [DataMember]
        public double peripheral_score { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double furnishing_score { get; set; }

        [DataMember]
        public string locality_type { get; set; }

        [DataMember]
        public string society_type { get; set; }

        [DataMember]
        public double poshness_index { get; set; }

        [DataMember]
        public Connectivity connectivity { get; set; }

        [DataMember]
        public Neighborhood neighbourhood { get; set; }

        [DataMember]
        public double neighbourhood_score { get; set; }
    }

    [DataContract]
    public class Connectivity
    {
        // TODO: Make entries for other types .. Good etc.
        [DataMember]
        public List<string> Bad { get; set; }

        [DataMember]
        public List<string> Great { get; set; }

        [DataMember]
        public List<string> Good { get; set; }

        [DataMember]
        public List<string> None { get; set; }
    }

    [DataContract]
    public class Neighborhood
    {
        // TODO: Make entries for other types .. Good etc.
        [DataMember]
        public List<string> Bad { get; set; }

        [DataMember]
        public List<string> None { get; set; }

        [DataMember]
        public List<string> Great { get; set; }

        [DataMember]
        public List<string> Good { get; set; }
    }

    [DataContract]
    public class ImageWithMasterTag
    {
        [DataMember]
        public string master_tag { get; set; }

        [DataMember]
        public List<Image> images { get; set; }
    }

    [DataContract]
    public class Image
    {
        [DataMember]
        public string absolute_url { get; set; }

        [DataMember]
        public string caption { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool is_landscape { get; set; }
    }
}

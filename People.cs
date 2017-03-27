using System.Collections.Generic;

namespace Models
{
    public class People
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<person> results { get; set; }
    }

    public class person
    {
        public string name 
		{ get; set; }
		
		public string height 
		{ get; set; }
		
		public string mass 
		{ get; set; }
		
		public string hair_color 
		{ get; set; }
		
		public string skin_color 
		{ get; set; }
		
		public string eye_color
		{ get; set; }
		
		public string birth_year
		{ get; set; }
		
        public string gender 
		{ get; set; }
        
		public string homeworld 
		{ get; set; }
        
		public string[] films 
		{ get; set; }
		
		public string[] species 
		{ get; set; }
		
		public string[] vehicles 
		{ get; set; }		
		
		public string[] starships 
		{ get; set; }
        
		public string created 
		{ get; set; }
        
		public string edited 
		{ get; set; }
        
		public string url 
		{ get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncannySoft.Schema.org
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    public class Thing
    {
        /// <summary>
        /// The unique identifier of the Thing
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, 
        /// it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. UncannySoft.Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        /// </summary>
        public Uri AdditionalType { get; set; }
        /// <summary>
        /// An alias for the item.
        /// </summary>
        public string AlternateName { get; set; }
        /// <summary>
        /// A short description of the item.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// An image of the item. This can be a URL or a fully described ImageObject.
        /// </summary>
        //public ImageObject Image { get; set; }
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>
        public Action PotentialAction { get; set; }
        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Freebase page, or official website.
        /// </summary>
        //public List<Link> SameAs { get; set; }
        /// <summary>
        /// URL of the item.
        /// </summary>
        public Uri Url { get; set; }
    }
}
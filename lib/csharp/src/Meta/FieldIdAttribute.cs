using System;

namespace Thrift.Meta {
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldIdAttribute : Attribute {

        public FieldIdAttribute(int id) {
            Id = id;
        }

        public int Id { get; set; }
    }
}

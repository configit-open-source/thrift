using System;

namespace Thrift.Meta {
  [AttributeUsage( AttributeTargets.Class )]
  public class TypeAttribute: Attribute {

    public TypeAttribute( string name ) {
      Name = name;
    }

    public string Name { get; set; }
  }
}

using System;

namespace Thrift.Meta {
  [AttributeUsage( AttributeTargets.Class )]
  public class StructAttribute: TypeAttribute {

    public StructAttribute( string name ) : base( name ) {
      Name = name;
    }
  }
}

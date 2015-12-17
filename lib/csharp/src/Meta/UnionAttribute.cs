using System;

namespace Thrift.Meta {
  [AttributeUsage( AttributeTargets.Class )]
  public class UnionAttribute: TypeAttribute {

    public UnionAttribute( string name )
      : base( name ) {
    }
  }
}

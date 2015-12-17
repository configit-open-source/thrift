using System;

namespace Thrift.Meta {
  [AttributeUsage( AttributeTargets.Class )]
  public class ExceptionAttribute: TypeAttribute {

    public ExceptionAttribute( string name )
      : base( name ) {
    }
  }
}

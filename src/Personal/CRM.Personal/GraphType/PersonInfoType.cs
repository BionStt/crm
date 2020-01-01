using CRM.Protobuf.Person.V1;
using HotChocolate.Types;

namespace CRM.Personal.GraphType
{
    public class PersonInfoType : ObjectType<PersonInfoDto>
    {
        protected override void Configure(IObjectTypeDescriptor<PersonInfoDto> descriptor)
        {
            descriptor.Field(t => t.CalculateSize()).Ignore();
            descriptor.Field(t => t.Clone()).Ignore();
            descriptor.Field(t => t.Equals(null)).Ignore();
        }
    }
}
using System;
using System.Threading.Tasks;
using NJsonSchema;
using NJsonSchema.Generation;
using NJsonSchema.Generation.TypeMappers;
using WebApiDemo.Models;

namespace WebApiDemo.NSwag
{
    public sealed class ErrorResponse<T>
    {
    }

    public sealed class ErrorResponseTypeMapper : ITypeMapper
    {
        public Type MappedType => typeof(ErrorResponse<>);

        public bool UseReference => true;

        public async Task GenerateSchemaAsync(JsonSchema4 schema, TypeMapperContext context)
        {
            schema.SchemaReference = await context.JsonSchemaGenerator.GenerateAsync(context.Type.GenericTypeArguments[0], context.JsonSchemaResolver);
        }
    }
}

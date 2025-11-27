using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for location in AwsApiGatewayDocumentationPart.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDocumentationPartLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location";

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => new TerraformReference<string>(this, "method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string>? StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_documentation_part Terraform resource.
/// Manages a aws_api_gateway_documentation_part resource.
/// </summary>
public partial class AwsApiGatewayDocumentationPart(string name) : TerraformResource("aws_api_gateway_documentation_part", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    public required TerraformValue<string> Properties
    {
        get => new TerraformReference<string>(this, "properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The documentation_part_id attribute.
    /// </summary>
    public TerraformValue<string> DocumentationPartId
    {
        get => new TerraformReference<string>(this, "documentation_part_id");
    }

    /// <summary>
    /// Location block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Location block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public required TerraformList<AwsApiGatewayDocumentationPartLocationBlock> Location
    {
        get => GetRequiredArgument<TerraformList<AwsApiGatewayDocumentationPartLocationBlock>>("location");
        set => SetArgument("location", value);
    }

}

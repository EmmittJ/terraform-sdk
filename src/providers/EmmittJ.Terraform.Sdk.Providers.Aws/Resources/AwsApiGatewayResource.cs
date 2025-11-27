using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_resource Terraform resource.
/// Manages a aws_api_gateway_resource resource.
/// </summary>
public partial class AwsApiGatewayResource(string name) : TerraformResource("aws_api_gateway_resource", name)
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
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformValue<string> ParentId
    {
        get => new TerraformReference<string>(this, "parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The path_part attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPart is required")]
    public required TerraformValue<string> PathPart
    {
        get => new TerraformReference<string>(this, "path_part");
        set => SetArgument("path_part", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

}

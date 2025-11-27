using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_base_path_mapping Terraform resource.
/// Manages a aws_api_gateway_base_path_mapping resource.
/// </summary>
public partial class AwsApiGatewayBasePathMapping(string name) : TerraformResource("aws_api_gateway_base_path_mapping", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The base_path attribute.
    /// </summary>
    public TerraformValue<string>? BasePath
    {
        get => new TerraformReference<string>(this, "base_path");
        set => SetArgument("base_path", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformValue<string>? DomainNameId
    {
        get => new TerraformReference<string>(this, "domain_name_id");
        set => SetArgument("domain_name_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The stage_name attribute.
    /// </summary>
    public TerraformValue<string>? StageName
    {
        get => new TerraformReference<string>(this, "stage_name");
        set => SetArgument("stage_name", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appsync_api_key Terraform resource.
/// Manages a aws_appsync_api_key resource.
/// </summary>
public partial class AwsAppsyncApiKey(string name) : TerraformResource("aws_appsync_api_key", name)
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformValue<string>? Expires
    {
        get => new TerraformReference<string>(this, "expires");
        set => SetArgument("expires", value);
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
    /// The api_key_id attribute.
    /// </summary>
    public TerraformValue<string> ApiKeyId
    {
        get => new TerraformReference<string>(this, "api_key_id");
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
    }

}

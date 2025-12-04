using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_user_pool_ui_customization Terraform resource.
/// Manages a aws_cognito_user_pool_ui_customization resource.
/// </summary>
public partial class AwsCognitoUserPoolUiCustomization(string name) : TerraformResource("aws_cognito_user_pool_ui_customization", name)
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The css attribute.
    /// </summary>
    public TerraformValue<string>? Css
    {
        get => GetArgument<TerraformValue<string>>("css");
        set => SetArgument("css", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_file attribute.
    /// </summary>
    public TerraformValue<string>? ImageFile
    {
        get => GetArgument<TerraformValue<string>>("image_file");
        set => SetArgument("image_file", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => AsReference("creation_date");

    /// <summary>
    /// The css_version attribute.
    /// </summary>
    public TerraformValue<string> CssVersion
        => AsReference("css_version");

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string> ImageUrl
        => AsReference("image_url");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => AsReference("last_modified_date");

}

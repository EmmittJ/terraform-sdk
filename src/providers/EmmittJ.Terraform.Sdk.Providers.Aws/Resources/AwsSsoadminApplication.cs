using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for portal_options in AwsSsoadminApplication.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminApplicationPortalOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "portal_options";

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string>? Visibility
    {
        get => GetArgument<TerraformValue<string>>("visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// SignInOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsoadminApplicationPortalOptionsBlockSignInOptionsBlock>? SignInOptions
    {
        get => GetArgument<TerraformList<AwsSsoadminApplicationPortalOptionsBlockSignInOptionsBlock>>("sign_in_options");
        set => SetArgument("sign_in_options", value);
    }

}

/// <summary>
/// Block type for sign_in_options in AwsSsoadminApplicationPortalOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminApplicationPortalOptionsBlockSignInOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sign_in_options";

    /// <summary>
    /// The application_url attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationUrl
    {
        get => GetArgument<TerraformValue<string>>("application_url");
        set => SetArgument("application_url", value);
    }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    public required TerraformValue<string> Origin
    {
        get => GetArgument<TerraformValue<string>>("origin");
        set => SetArgument("origin", value);
    }

}


/// <summary>
/// Represents a aws_ssoadmin_application Terraform resource.
/// Manages a aws_ssoadmin_application resource.
/// </summary>
public partial class AwsSsoadminApplication(string name) : TerraformResource("aws_ssoadmin_application", name)
{
    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationProviderArn is required")]
    public required TerraformValue<string> ApplicationProviderArn
    {
        get => GetArgument<TerraformValue<string>>("application_provider_arn");
        set => SetArgument("application_provider_arn", value);
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformValue<string>? ClientToken
    {
        get => GetArgument<TerraformValue<string>>("client_token");
        set => SetArgument("client_token", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    public TerraformValue<string> ApplicationAccount
        => AsReference("application_account");

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ApplicationArn
        => AsReference("application_arn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// PortalOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsoadminApplicationPortalOptionsBlock>? PortalOptions
    {
        get => GetArgument<TerraformList<AwsSsoadminApplicationPortalOptionsBlock>>("portal_options");
        set => SetArgument("portal_options", value);
    }

}

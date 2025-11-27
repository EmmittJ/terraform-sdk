using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_user Terraform resource.
/// Manages a aws_cognito_user resource.
/// </summary>
public partial class AwsCognitoUser(string name) : TerraformResource("aws_cognito_user", name)
{
    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformMap<string>? Attributes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "attributes").ResolveNodes(ctx));
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    public TerraformMap<string>? ClientMetadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "client_metadata").ResolveNodes(ctx));
        set => SetArgument("client_metadata", value);
    }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    public TerraformSet<string>? DesiredDeliveryMediums
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "desired_delivery_mediums").ResolveNodes(ctx));
        set => SetArgument("desired_delivery_mediums", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    public TerraformValue<bool>? ForceAliasCreation
    {
        get => new TerraformReference<bool>(this, "force_alias_creation");
        set => SetArgument("force_alias_creation", value);
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
    /// The message_action attribute.
    /// </summary>
    public TerraformValue<string>? MessageAction
    {
        get => new TerraformReference<string>(this, "message_action");
        set => SetArgument("message_action", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
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
    /// The temporary_password attribute.
    /// </summary>
    public TerraformValue<string>? TemporaryPassword
    {
        get => new TerraformReference<string>(this, "temporary_password");
        set => SetArgument("temporary_password", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    public TerraformMap<string>? ValidationData
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "validation_data").ResolveNodes(ctx));
        set => SetArgument("validation_data", value);
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
    {
        get => new TerraformReference<string>(this, "last_modified_date");
    }

    /// <summary>
    /// The mfa_setting_list attribute.
    /// </summary>
    public TerraformSet<string> MfaSettingList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "mfa_setting_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The preferred_mfa_setting attribute.
    /// </summary>
    public TerraformValue<string> PreferredMfaSetting
    {
        get => new TerraformReference<string>(this, "preferred_mfa_setting");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The sub attribute.
    /// </summary>
    public TerraformValue<string> Sub
    {
        get => new TerraformReference<string>(this, "sub");
    }

}

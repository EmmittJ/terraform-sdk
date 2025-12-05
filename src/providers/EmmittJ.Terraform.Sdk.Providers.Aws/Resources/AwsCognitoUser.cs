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
        get => GetArgument<TerraformMap<string>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    public TerraformMap<string>? ClientMetadata
    {
        get => GetArgument<TerraformMap<string>>("client_metadata");
        set => SetArgument("client_metadata", value);
    }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    public TerraformSet<string>? DesiredDeliveryMediums
    {
        get => GetArgument<TerraformSet<string>>("desired_delivery_mediums");
        set => SetArgument("desired_delivery_mediums", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    public TerraformValue<bool>? ForceAliasCreation
    {
        get => GetArgument<TerraformValue<bool>>("force_alias_creation");
        set => SetArgument("force_alias_creation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message_action attribute.
    /// </summary>
    public TerraformValue<string>? MessageAction
    {
        get => GetArgument<TerraformValue<string>>("message_action");
        set => SetArgument("message_action", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The temporary_password attribute.
    /// </summary>
    public TerraformValue<string>? TemporaryPassword
    {
        get => GetArgument<TerraformValue<string>>("temporary_password");
        set => SetArgument("temporary_password", value);
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
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    public TerraformMap<string>? ValidationData
    {
        get => GetArgument<TerraformMap<string>>("validation_data");
        set => SetArgument("validation_data", value);
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => CreateReference("creation_date");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => CreateReference("last_modified_date");

    /// <summary>
    /// The mfa_setting_list attribute.
    /// </summary>
    public TerraformSet<string> MfaSettingList
        => CreateReference("mfa_setting_list");

    /// <summary>
    /// The preferred_mfa_setting attribute.
    /// </summary>
    public TerraformValue<string> PreferredMfaSetting
        => CreateReference("preferred_mfa_setting");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The sub attribute.
    /// </summary>
    public TerraformValue<string> Sub
        => CreateReference("sub");

}

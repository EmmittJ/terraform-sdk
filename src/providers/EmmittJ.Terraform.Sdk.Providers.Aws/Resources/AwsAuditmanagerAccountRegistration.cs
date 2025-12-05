using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_auditmanager_account_registration Terraform resource.
/// Manages a aws_auditmanager_account_registration resource.
/// </summary>
public partial class AwsAuditmanagerAccountRegistration(string name) : TerraformResource("aws_auditmanager_account_registration", name)
{
    /// <summary>
    /// The delegated_admin_account attribute.
    /// </summary>
    public TerraformValue<string>? DelegatedAdminAccount
    {
        get => GetArgument<TerraformValue<string>>("delegated_admin_account");
        set => SetArgument("delegated_admin_account", value);
    }

    /// <summary>
    /// The deregister_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? DeregisterOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("deregister_on_destroy");
        set => SetArgument("deregister_on_destroy", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
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
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glacier_vault_lock Terraform resource.
/// Manages a aws_glacier_vault_lock resource.
/// </summary>
public partial class AwsGlacierVaultLock(string name) : TerraformResource("aws_glacier_vault_lock", name)
{
    /// <summary>
    /// The complete_lock attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CompleteLock is required")]
    public required TerraformValue<bool> CompleteLock
    {
        get => GetRequiredArgument<TerraformValue<bool>>("complete_lock");
        set => SetArgument("complete_lock", value);
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
    /// The ignore_deletion_error attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreDeletionError
    {
        get => GetArgument<TerraformValue<bool>>("ignore_deletion_error");
        set => SetArgument("ignore_deletion_error", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
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
    /// The vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    public required TerraformValue<string> VaultName
    {
        get => GetRequiredArgument<TerraformValue<string>>("vault_name");
        set => SetArgument("vault_name", value);
    }

}

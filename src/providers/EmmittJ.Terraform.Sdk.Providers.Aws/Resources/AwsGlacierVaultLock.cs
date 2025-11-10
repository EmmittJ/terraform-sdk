using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glacier_vault_lock resource.
/// </summary>
public class AwsGlacierVaultLock : TerraformResource
{
    public AwsGlacierVaultLock(string name) : base("aws_glacier_vault_lock", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("complete_lock");
        SetOutput("id");
        SetOutput("ignore_deletion_error");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("vault_name");
    }

    /// <summary>
    /// The complete_lock attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CompleteLock is required")]
    public required TerraformProperty<bool> CompleteLock
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("complete_lock");
        set => SetProperty("complete_lock", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_deletion_error attribute.
    /// </summary>
    public TerraformProperty<bool> IgnoreDeletionError
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_deletion_error");
        set => SetProperty("ignore_deletion_error", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    public required TerraformProperty<string> VaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_name");
        set => SetProperty("vault_name", value);
    }

}

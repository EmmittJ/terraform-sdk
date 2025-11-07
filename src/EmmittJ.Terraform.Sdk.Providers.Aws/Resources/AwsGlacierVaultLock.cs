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
    }

    /// <summary>
    /// The complete_lock attribute.
    /// </summary>
    public TerraformProperty<bool>? CompleteLock
    {
        get => GetProperty<TerraformProperty<bool>>("complete_lock");
        set => this.WithProperty("complete_lock", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_deletion_error attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreDeletionError
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_deletion_error");
        set => this.WithProperty("ignore_deletion_error", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    public TerraformProperty<string>? VaultName
    {
        get => GetProperty<TerraformProperty<string>>("vault_name");
        set => this.WithProperty("vault_name", value);
    }

}

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
    public TerraformLiteralProperty<bool>? CompleteLock
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("complete_lock");
        set => this.WithProperty("complete_lock", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_deletion_error attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IgnoreDeletionError
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_deletion_error");
        set => this.WithProperty("ignore_deletion_error", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_name");
        set => this.WithProperty("vault_name", value);
    }

}

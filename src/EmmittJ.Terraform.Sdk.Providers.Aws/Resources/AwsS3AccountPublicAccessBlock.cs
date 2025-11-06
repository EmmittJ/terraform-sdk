using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_account_public_access_block resource.
/// </summary>
public class AwsS3AccountPublicAccessBlock : TerraformResource
{
    public AwsS3AccountPublicAccessBlock(string name) : base("aws_s3_account_public_access_block", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public bool? BlockPublicAcls
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_acls")?.Value;
        set => this.WithProperty("block_public_acls", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public bool? BlockPublicPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_policy")?.Value;
        set => this.WithProperty("block_public_policy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public bool? IgnorePublicAcls
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_public_acls")?.Value;
        set => this.WithProperty("ignore_public_acls", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public bool? RestrictPublicBuckets
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("restrict_public_buckets")?.Value;
        set => this.WithProperty("restrict_public_buckets", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}

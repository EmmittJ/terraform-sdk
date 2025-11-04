using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_drt_access_log_bucket_association resource.
/// </summary>
public class AwsShieldDrtAccessLogBucketAssociation : TerraformResource
{
    public AwsShieldDrtAccessLogBucketAssociation(string name) : base("aws_shield_drt_access_log_bucket_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The log_bucket attribute.
    /// </summary>
    public string? LogBucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_bucket")?.Value;
        set => this.WithProperty("log_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Unused
    /// </summary>
    public string? RoleArnAssociationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn_association_id")?.Value;
        set => this.WithProperty("role_arn_association_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

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
    public TerraformProperty<string>? LogBucket
    {
        get => GetProperty<TerraformProperty<string>>("log_bucket");
        set => this.WithProperty("log_bucket", value);
    }

    /// <summary>
    /// Unused
    /// </summary>
    public TerraformProperty<string>? RoleArnAssociationId
    {
        get => GetProperty<TerraformProperty<string>>("role_arn_association_id");
        set => this.WithProperty("role_arn_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

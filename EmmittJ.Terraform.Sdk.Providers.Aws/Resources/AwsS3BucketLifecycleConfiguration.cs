using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_lifecycle_configuration resource.
/// </summary>
public class AwsS3BucketLifecycleConfiguration : TerraformResource
{
    public AwsS3BucketLifecycleConfiguration(string name) : base("aws_s3_bucket_lifecycle_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public string? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner")?.Value;
        set => this.WithProperty("expected_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transition_default_minimum_object_size attribute.
    /// </summary>
    public string? TransitionDefaultMinimumObjectSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transition_default_minimum_object_size")?.Value;
        set => this.WithProperty("transition_default_minimum_object_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

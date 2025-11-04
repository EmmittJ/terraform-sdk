using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_table_policy resource.
/// </summary>
public class AwsS3tablesTablePolicy : TerraformResource
{
    public AwsS3tablesTablePolicy(string name) : base("aws_s3tables_table_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public string? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace")?.Value;
        set => this.WithProperty("namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_policy attribute.
    /// </summary>
    public string? ResourcePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_policy")?.Value;
        set => this.WithProperty("resource_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    public string? TableBucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_bucket_arn")?.Value;
        set => this.WithProperty("table_bucket_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

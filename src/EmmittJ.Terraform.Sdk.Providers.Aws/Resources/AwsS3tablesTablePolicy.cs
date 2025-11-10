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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The resource_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourcePolicy is required")]
    public required TerraformProperty<string> ResourcePolicy
    {
        get => GetProperty<TerraformProperty<string>>("resource_policy");
        set => this.WithProperty("resource_policy", value);
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformProperty<string> TableBucketArn
    {
        get => GetProperty<TerraformProperty<string>>("table_bucket_arn");
        set => this.WithProperty("table_bucket_arn", value);
    }

}

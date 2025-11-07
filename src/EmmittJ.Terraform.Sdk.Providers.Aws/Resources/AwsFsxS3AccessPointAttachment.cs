using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_s3_access_point_attachment resource.
/// </summary>
public class AwsFsxS3AccessPointAttachment : TerraformResource
{
    public AwsFsxS3AccessPointAttachment(string name) : base("aws_fsx_s3_access_point_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("s3_access_point_alias");
        this.DeclareOutput("s3_access_point_arn");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The s3_access_point_alias attribute.
    /// </summary>
    public TerraformExpression S3AccessPointAlias => this["s3_access_point_alias"];

    /// <summary>
    /// The s3_access_point_arn attribute.
    /// </summary>
    public TerraformExpression S3AccessPointArn => this["s3_access_point_arn"];

}

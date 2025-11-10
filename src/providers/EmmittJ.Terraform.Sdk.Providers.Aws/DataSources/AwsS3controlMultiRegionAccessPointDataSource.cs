using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3control_multi_region_access_point.
/// </summary>
public class AwsS3controlMultiRegionAccessPointDataSource : TerraformDataSource
{
    public AwsS3controlMultiRegionAccessPointDataSource(string name) : base("aws_s3control_multi_region_access_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("alias");
        this.WithOutput("arn");
        this.WithOutput("created_at");
        this.WithOutput("domain_name");
        this.WithOutput("public_access_block");
        this.WithOutput("regions");
        this.WithOutput("status");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The public_access_block attribute.
    /// </summary>
    public TerraformExpression PublicAccessBlock => this["public_access_block"];

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformExpression Regions => this["regions"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

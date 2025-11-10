using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_identity_center_configuration resource.
/// </summary>
public class AwsLakeformationIdentityCenterConfiguration : TerraformResource
{
    public AwsLakeformationIdentityCenterConfiguration(string name) : base("aws_lakeformation_identity_center_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_arn");
        SetOutput("resource_share");
        SetOutput("catalog_id");
        SetOutput("instance_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    public TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The ARN of the Identity Center instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformProperty<string> InstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_arn");
        set => SetProperty("instance_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformExpression ApplicationArn => this["application_arn"];

    /// <summary>
    /// The resource_share attribute.
    /// </summary>
    public TerraformExpression ResourceShare => this["resource_share"];

}

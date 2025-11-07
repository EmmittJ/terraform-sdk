using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicecatalog_provisioning_artifacts.
/// </summary>
public class AwsServicecatalogProvisioningArtifactsDataSource : TerraformDataSource
{
    public AwsServicecatalogProvisioningArtifactsDataSource(string name) : base("aws_servicecatalog_provisioning_artifacts", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("provisioning_artifact_details");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
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
    /// The product_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
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
    /// The provisioning_artifact_details attribute.
    /// </summary>
    public TerraformExpression ProvisioningArtifactDetails => this["provisioning_artifact_details"];

}

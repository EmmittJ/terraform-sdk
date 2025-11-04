using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_custom_key_store.
/// </summary>
public class AwsKmsCustomKeyStoreDataSource : TerraformDataSource
{
    public AwsKmsCustomKeyStoreDataSource(string name) : base("aws_kms_custom_key_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cloud_hsm_cluster_id");
        this.DeclareOutput("connection_state");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("trust_anchor_certificate");
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public string? CustomKeyStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_id")?.Value;
        set => this.WithProperty("custom_key_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    public string? CustomKeyStoreName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_name")?.Value;
        set => this.WithProperty("custom_key_store_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformExpression CloudHsmClusterId => this["cloud_hsm_cluster_id"];

    /// <summary>
    /// The connection_state attribute.
    /// </summary>
    public TerraformExpression ConnectionState => this["connection_state"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public TerraformExpression TrustAnchorCertificate => this["trust_anchor_certificate"];

}

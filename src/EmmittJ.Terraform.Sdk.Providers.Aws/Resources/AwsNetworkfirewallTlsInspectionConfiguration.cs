using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkfirewall_tls_inspection_configuration resource.
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfiguration : TerraformResource
{
    public AwsNetworkfirewallTlsInspectionConfiguration(string name) : base("aws_networkfirewall_tls_inspection_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_authority");
        this.DeclareOutput("certificates");
        this.DeclareOutput("id");
        this.DeclareOutput("number_of_associations");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("tls_inspection_configuration_id");
        this.DeclareOutput("update_token");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformProperty<List<object>>? EncryptionConfiguration
    {
        get => GetProperty<TerraformProperty<List<object>>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    public TerraformExpression CertificateAuthority => this["certificate_authority"];

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformExpression Certificates => this["certificates"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The number_of_associations attribute.
    /// </summary>
    public TerraformExpression NumberOfAssociations => this["number_of_associations"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The tls_inspection_configuration_id attribute.
    /// </summary>
    public TerraformExpression TlsInspectionConfigurationId => this["tls_inspection_configuration_id"];

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

}

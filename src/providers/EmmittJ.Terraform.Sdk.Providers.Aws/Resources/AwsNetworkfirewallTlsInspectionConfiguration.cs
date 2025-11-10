using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for tls_inspection_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock : TerraformBlock
{
}

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
        this.WithOutput("arn");
        this.WithOutput("certificate_authority");
        this.WithOutput("certificates");
        this.WithOutput("id");
        this.WithOutput("number_of_associations");
        this.WithOutput("tags_all");
        this.WithOutput("tls_inspection_configuration_id");
        this.WithOutput("update_token");
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
    public List<TerraformProperty<object>>? EncryptionConfiguration
    {
        get => GetProperty<List<TerraformProperty<object>>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls_inspection_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock>? TlsInspectionConfiguration
    {
        get => GetProperty<List<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock>>("tls_inspection_configuration");
        set => this.WithProperty("tls_inspection_configuration", value);
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

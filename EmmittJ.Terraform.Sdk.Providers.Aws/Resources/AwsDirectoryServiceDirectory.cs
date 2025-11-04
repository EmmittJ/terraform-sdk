using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_directory resource.
/// </summary>
public class AwsDirectoryServiceDirectory : TerraformResource
{
    public AwsDirectoryServiceDirectory(string name) : base("aws_directory_service_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_url");
        this.DeclareOutput("dns_ip_addresses");
        this.DeclareOutput("security_group_id");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public string? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias")?.Value;
        set => this.WithProperty("alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The desired_number_of_domain_controllers attribute.
    /// </summary>
    public double? DesiredNumberOfDomainControllers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_number_of_domain_controllers")?.Value;
        set => this.WithProperty("desired_number_of_domain_controllers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public string? Edition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edition")?.Value;
        set => this.WithProperty("edition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public bool? EnableSso
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_sso")?.Value;
        set => this.WithProperty("enable_sso", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public string? ShortName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("short_name")?.Value;
        set => this.WithProperty("short_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public string? Size
    {
        get => GetProperty<TerraformLiteralProperty<string>>("size")?.Value;
        set => this.WithProperty("size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    public TerraformExpression AccessUrl => this["access_url"];

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformExpression DnsIpAddresses => this["dns_ip_addresses"];

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupId => this["security_group_id"];

}

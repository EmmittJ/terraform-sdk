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
    public TerraformProperty<string>? Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
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
    /// The desired_number_of_domain_controllers attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredNumberOfDomainControllers
    {
        get => GetProperty<TerraformProperty<double>>("desired_number_of_domain_controllers");
        set => this.WithProperty("desired_number_of_domain_controllers", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        get => GetProperty<TerraformProperty<string>>("edition");
        set => this.WithProperty("edition", value);
    }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSso
    {
        get => GetProperty<TerraformProperty<bool>>("enable_sso");
        set => this.WithProperty("enable_sso", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
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
    /// The short_name attribute.
    /// </summary>
    public TerraformProperty<string>? ShortName
    {
        get => GetProperty<TerraformProperty<string>>("short_name");
        set => this.WithProperty("short_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string>? Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_directory_service_directory.
/// </summary>
public class AwsDirectoryServiceDirectoryDataSource : TerraformDataSource
{
    public AwsDirectoryServiceDirectoryDataSource(string name) : base("aws_directory_service_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_url");
        this.DeclareOutput("alias");
        this.DeclareOutput("connect_settings");
        this.DeclareOutput("description");
        this.DeclareOutput("dns_ip_addresses");
        this.DeclareOutput("edition");
        this.DeclareOutput("enable_sso");
        this.DeclareOutput("name");
        this.DeclareOutput("radius_settings");
        this.DeclareOutput("security_group_id");
        this.DeclareOutput("short_name");
        this.DeclareOutput("size");
        this.DeclareOutput("type");
        this.DeclareOutput("vpc_settings");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
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
    /// The access_url attribute.
    /// </summary>
    public TerraformExpression AccessUrl => this["access_url"];

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The connect_settings attribute.
    /// </summary>
    public TerraformExpression ConnectSettings => this["connect_settings"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformExpression DnsIpAddresses => this["dns_ip_addresses"];

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformExpression Edition => this["edition"];

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public TerraformExpression EnableSso => this["enable_sso"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The radius_settings attribute.
    /// </summary>
    public TerraformExpression RadiusSettings => this["radius_settings"];

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupId => this["security_group_id"];

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformExpression ShortName => this["short_name"];

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformExpression Size => this["size"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The vpc_settings attribute.
    /// </summary>
    public TerraformExpression VpcSettings => this["vpc_settings"];

}

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
        SetOutput("access_url");
        SetOutput("alias");
        SetOutput("connect_settings");
        SetOutput("description");
        SetOutput("dns_ip_addresses");
        SetOutput("edition");
        SetOutput("enable_sso");
        SetOutput("name");
        SetOutput("radius_settings");
        SetOutput("security_group_id");
        SetOutput("short_name");
        SetOutput("size");
        SetOutput("type");
        SetOutput("vpc_settings");
        SetOutput("directory_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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

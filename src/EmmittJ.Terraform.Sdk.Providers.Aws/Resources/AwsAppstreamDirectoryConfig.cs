using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appstream_directory_config resource.
/// </summary>
public class AwsAppstreamDirectoryConfig : TerraformResource
{
    public AwsAppstreamDirectoryConfig(string name) : base("aws_appstream_directory_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_time");
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryName
    {
        get => GetProperty<TerraformProperty<string>>("directory_name");
        set => this.WithProperty("directory_name", value);
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
    /// The organizational_unit_distinguished_names attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? OrganizationalUnitDistinguishedNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("organizational_unit_distinguished_names");
        set => this.WithProperty("organizational_unit_distinguished_names", value);
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
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

}

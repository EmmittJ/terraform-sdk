using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_ontap_storage_virtual_machine resource.
/// </summary>
public class AwsFsxOntapStorageVirtualMachine : TerraformResource
{
    public AwsFsxOntapStorageVirtualMachine(string name) : base("aws_fsx_ontap_storage_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("subtype");
        this.DeclareOutput("uuid");
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public string? FileSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_id")?.Value;
        set => this.WithProperty("file_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The root_volume_security_style attribute.
    /// </summary>
    public string? RootVolumeSecurityStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_volume_security_style")?.Value;
        set => this.WithProperty("root_volume_security_style", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The svm_admin_password attribute.
    /// </summary>
    public string? SvmAdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("svm_admin_password")?.Value;
        set => this.WithProperty("svm_admin_password", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    public TerraformExpression Subtype => this["subtype"];

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}

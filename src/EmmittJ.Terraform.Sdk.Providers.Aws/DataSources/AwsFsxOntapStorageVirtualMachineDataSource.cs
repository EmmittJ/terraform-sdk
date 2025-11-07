using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_ontap_storage_virtual_machine.
/// </summary>
public class AwsFsxOntapStorageVirtualMachineDataSource : TerraformDataSource
{
    public AwsFsxOntapStorageVirtualMachineDataSource(string name) : base("aws_fsx_ontap_storage_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("active_directory_configuration");
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("file_system_id");
        this.DeclareOutput("lifecycle_status");
        this.DeclareOutput("lifecycle_transition_reason");
        this.DeclareOutput("name");
        this.DeclareOutput("subtype");
        this.DeclareOutput("uuid");
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
    /// The active_directory_configuration attribute.
    /// </summary>
    public TerraformExpression ActiveDirectoryConfiguration => this["active_directory_configuration"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformExpression FileSystemId => this["file_system_id"];

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    public TerraformExpression LifecycleStatus => this["lifecycle_status"];

    /// <summary>
    /// The lifecycle_transition_reason attribute.
    /// </summary>
    public TerraformExpression LifecycleTransitionReason => this["lifecycle_transition_reason"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    public TerraformExpression Subtype => this["subtype"];

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}

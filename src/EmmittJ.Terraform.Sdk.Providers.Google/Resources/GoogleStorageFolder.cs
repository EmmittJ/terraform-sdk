using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_folder resource.
/// </summary>
public class GoogleStorageFolder : TerraformResource
{
    public GoogleStorageFolder(string name) : base("google_storage_folder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("metageneration");
        this.DeclareOutput("self_link");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The name of the bucket that contains the folder.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// If set to true, items within folder if any will be force destroyed.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The name of the folder expressed as a path. Must include
    /// trailing &#39;/&#39;. For example, &#39;example_dir/example_dir2/&#39;, &#39;example@#/&#39;, &#39;a-b/d-f/&#39;.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The timestamp at which this folder was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The metadata generation of the folder.
    /// </summary>
    public TerraformExpression Metageneration => this["metageneration"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The timestamp at which this folder was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

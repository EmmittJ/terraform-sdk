using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageManagedFolderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_storage_managed_folder resource.
/// </summary>
public class GoogleStorageManagedFolder : TerraformResource
{
    public GoogleStorageManagedFolder(string name) : base("google_storage_managed_folder", name)
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
    /// The name of the bucket that contains the managed folder.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Allows the deletion of a managed folder even if contains
    /// objects. If a non-empty managed folder is deleted, any objects
    /// within the folder will remain in a simulated folder with the
    /// same name.
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
    /// The name of the managed folder expressed as a path. Must include
    /// trailing &#39;/&#39;. For example, &#39;example_dir/example_dir2/&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageManagedFolderTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageManagedFolderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp at which this managed folder was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The metadata generation of the managed folder.
    /// </summary>
    public TerraformExpression Metageneration => this["metageneration"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The timestamp at which this managed folder was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFolderTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a google_folder resource.
/// </summary>
public class GoogleFolder : TerraformResource
{
    public GoogleFolder(string name) : base("google_folder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("configured_capabilities");
        this.WithOutput("create_time");
        this.WithOutput("folder_id");
        this.WithOutput("lifecycle_state");
        this.WithOutput("management_project");
        this.WithOutput("name");
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The folder&#39;s display name. A folder&#39;s display name must be unique amongst its siblings, e.g. no two folders with the same parent can share the same display name. The display name must start and end with a letter or digit, may contain letters, digits, spaces, hyphens and underscores and can be no longer than 30 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The resource name of the parent Folder or Organization. Must be of the form folders/{folder_id} or organizations/{org_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored when empty. This field is only set at create time and modifying this field after creation will trigger recreation. To apply tags to an existing resource, see the google_tags_tag_value resource.
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
    public GoogleFolderTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFolderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A list of capabilities that are configured for this folder.
    /// </summary>
    public TerraformExpression ConfiguredCapabilities => this["configured_capabilities"];

    /// <summary>
    /// Timestamp when the Folder was created. Assigned by the server. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The folder id from the name &amp;quot;folders/{folder_id}&amp;quot;
    /// </summary>
    public TerraformExpression FolderId => this["folder_id"];

    /// <summary>
    /// The lifecycle state of the folder such as ACTIVE or DELETE_REQUESTED.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The Management Project associated with the folder&#39;s configured capabilities.
    /// </summary>
    public TerraformExpression ManagementProject => this["management_project"];

    /// <summary>
    /// The resource name of the Folder. Its format is folders/{folder_id}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}

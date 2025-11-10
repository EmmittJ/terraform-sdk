using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSettingsMetadataBlock : TerraformBlock
{
    /// <summary>
    /// A metadata key/value items map. The total size of all keys and values must be less than 512KB
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Items
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("items");
        set => WithProperty("items", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceSettingsTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_instance_settings resource.
/// </summary>
public class GoogleComputeInstanceSettings : TerraformResource
{
    public GoogleComputeInstanceSettings(string name) : base("google_compute_instance_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fingerprint");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformProperty<string> Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public List<GoogleComputeInstanceSettingsMetadataBlock>? Metadata
    {
        get => GetProperty<List<GoogleComputeInstanceSettingsMetadataBlock>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceSettingsTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInstanceSettingsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

}

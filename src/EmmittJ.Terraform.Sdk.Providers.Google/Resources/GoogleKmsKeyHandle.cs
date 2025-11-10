using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsKeyHandleTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_kms_key_handle resource.
/// </summary>
public class GoogleKmsKeyHandle : TerraformResource
{
    public GoogleKmsKeyHandle(string name) : base("google_kms_key_handle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("kms_key");
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
    /// The location for the KeyHandle.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name for the KeyHandle.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Selector of the resource type where we want to protect resources.
    /// For example, &#39;storage.googleapis.com/Bucket&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    public required TerraformProperty<string> ResourceTypeSelector
    {
        get => GetProperty<TerraformProperty<string>>("resource_type_selector");
        set => this.WithProperty("resource_type_selector", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleKmsKeyHandleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleKmsKeyHandleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A reference to a Cloud KMS CryptoKey that can be used for CMEK in the requested
    /// product/project/location, for example
    /// &#39;projects/1/locations/us-east1/keyRings/foo/cryptoKeys/bar-ffffff&#39;
    /// </summary>
    public TerraformExpression KmsKey => this["kms_key"];

}

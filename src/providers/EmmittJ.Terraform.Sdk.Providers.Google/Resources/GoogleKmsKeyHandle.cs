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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("kms_key");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("resource_type_selector");
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
    /// The location for the KeyHandle.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name for the KeyHandle.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Selector of the resource type where we want to protect resources.
    /// For example, &#39;storage.googleapis.com/Bucket&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    public required TerraformProperty<string> ResourceTypeSelector
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type_selector");
        set => SetProperty("resource_type_selector", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleKmsKeyHandleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A reference to a Cloud KMS CryptoKey that can be used for CMEK in the requested
    /// product/project/location, for example
    /// &#39;projects/1/locations/us-east1/keyRings/foo/cryptoKeys/bar-ffffff&#39;
    /// </summary>
    public TerraformExpression KmsKey => this["kms_key"];

}

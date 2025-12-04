using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleKmsKeyHandle.
/// Nesting mode: single
/// </summary>
public class GoogleKmsKeyHandleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_kms_key_handle Terraform resource.
/// Manages a google_kms_key_handle resource.
/// </summary>
public partial class GoogleKmsKeyHandle(string name) : TerraformResource("google_kms_key_handle", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the KeyHandle.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name for the KeyHandle.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Selector of the resource type where we want to protect resources.
    /// For example, &#39;storage.googleapis.com/Bucket&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    public required TerraformValue<string> ResourceTypeSelector
    {
        get => GetArgument<TerraformValue<string>>("resource_type_selector");
        set => SetArgument("resource_type_selector", value);
    }

    /// <summary>
    /// A reference to a Cloud KMS CryptoKey that can be used for CMEK in the requested
    /// product/project/location, for example
    /// &#39;projects/1/locations/us-east1/keyRings/foo/cryptoKeys/bar-ffffff&#39;
    /// </summary>
    public TerraformValue<string> KmsKey
        => AsReference("kms_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleKmsKeyHandleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleKmsKeyHandleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

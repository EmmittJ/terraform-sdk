using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleDialogflowEncryptionSpec.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowEncryptionSpecEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// The name of customer-managed encryption key that is used to secure a resource and its sub-resources.
    /// If empty, the resource is secured by the default Google encryption key.
    /// Only the key in the same location as this resource is allowed to be used for encryption.
    /// Format: projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{key}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowEncryptionSpec.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowEncryptionSpecTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_encryption_spec Terraform resource.
/// Manages a google_dialogflow_encryption_spec resource.
/// </summary>
public partial class GoogleDialogflowEncryptionSpec(string name) : TerraformResource("google_dialogflow_encryption_spec", name)
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
    /// The location in which the encryptionSpec is to be initialized.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// EncryptionSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public required TerraformList<GoogleDialogflowEncryptionSpecEncryptionSpecBlock> EncryptionSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDialogflowEncryptionSpecEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowEncryptionSpecTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowEncryptionSpecTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

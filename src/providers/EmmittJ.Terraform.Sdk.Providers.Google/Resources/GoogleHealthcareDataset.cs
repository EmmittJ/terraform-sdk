using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleHealthcareDataset.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareDatasetEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// KMS encryption key that is used to secure this dataset and its sub-resources. The key used for
    /// encryption and the dataset must be in the same location. If empty, the default Google encryption
    /// key will be used to secure this dataset. The format is
    /// projects/{projectId}/locations/{locationId}/keyRings/{keyRingId}/cryptoKeys/{keyId}.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleHealthcareDataset.
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareDatasetTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_healthcare_dataset Terraform resource.
/// Manages a google_healthcare_dataset resource.
/// </summary>
public partial class GoogleHealthcareDataset(string name) : TerraformResource("google_healthcare_dataset", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the Dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name for the Dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The default timezone used by this dataset. Must be a either a valid IANA time zone name such as
    /// &amp;quot;America/New_York&amp;quot; or empty, which defaults to UTC. This is used for parsing times in resources
    /// (e.g., HL7 messages) where no explicit timezone is specified.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleHealthcareDatasetEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleHealthcareDatasetEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleHealthcareDatasetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleHealthcareDatasetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

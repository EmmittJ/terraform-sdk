using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dictionary in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionStoredInfoTypeDictionaryBlock() : TerraformBlock("dictionary")
{
}

/// <summary>
/// Block type for large_custom_dictionary in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock() : TerraformBlock("large_custom_dictionary")
{
}

/// <summary>
/// Block type for regex in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionStoredInfoTypeRegexBlock() : TerraformBlock("regex")
{
    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    [TerraformProperty("group_indexes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformProperty("pattern")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Pattern { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_loss_prevention_stored_info_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataLossPreventionStoredInfoType : TerraformResource
{
    public GoogleDataLossPreventionStoredInfoType(string name) : base("google_data_loss_prevention_stored_info_type", name)
    {
    }

    /// <summary>
    /// A description of the info type.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User set display name of the info type.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent of the info type in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    [TerraformProperty("stored_info_type_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StoredInfoTypeId { get; set; }

    /// <summary>
    /// Block for dictionary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    [TerraformProperty("dictionary")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlock> Dictionary { get; set; } = new();

    /// <summary>
    /// Block for large_custom_dictionary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LargeCustomDictionary block(s) allowed")]
    [TerraformProperty("large_custom_dictionary")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock> LargeCustomDictionary { get; set; } = new();

    /// <summary>
    /// Block for regex.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    [TerraformProperty("regex")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeRegexBlock> Regex { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the info type. Set by the server.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}

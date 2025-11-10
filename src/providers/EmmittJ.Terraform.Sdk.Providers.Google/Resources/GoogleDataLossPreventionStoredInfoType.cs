using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dictionary in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeDictionaryBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for large_custom_dictionary in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for regex in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeRegexBlock : ITerraformBlock
{
    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    [TerraformPropertyName("group_indexes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<double>>>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformPropertyName("pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Pattern { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_loss_prevention_stored_info_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionStoredInfoType : TerraformResource
{
    public GoogleDataLossPreventionStoredInfoType(string name) : base("google_data_loss_prevention_stored_info_type", name)
    {
    }

    /// <summary>
    /// A description of the info type.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// User set display name of the info type.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parent of the info type in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    [TerraformPropertyName("stored_info_type_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StoredInfoTypeId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stored_info_type_id");

    /// <summary>
    /// Block for dictionary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    [TerraformPropertyName("dictionary")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionStoredInfoTypeDictionaryBlock>>? Dictionary { get; set; } = new();

    /// <summary>
    /// Block for large_custom_dictionary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LargeCustomDictionary block(s) allowed")]
    [TerraformPropertyName("large_custom_dictionary")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock>>? LargeCustomDictionary { get; set; } = new();

    /// <summary>
    /// Block for regex.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    [TerraformPropertyName("regex")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionStoredInfoTypeRegexBlock>>? Regex { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the info type. Set by the server.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}

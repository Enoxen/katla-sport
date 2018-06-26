using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatlaSport.Services.HiveManagement
{
    /// <summary>
    /// Represents a hive section service.
    /// </summary>
    public interface IHiveSectionService
    {
        /// <summary>
        /// Deletes existing hive section.
        /// </summary>
        /// <param name="sectionId">ID of a section..</param>
        /// <returns>Task wit hive section.</returns>
        Task DeleteHiveSectionAsync(int sectionId);

        /// <summary>
        /// Updates existing hive section.
        /// </summary>
        /// <param name="sectionId">ID of a section.</param>
        /// <param name="updateRequest">Object with data.</param>
        /// <returns>Task with give Section.</returns>
        Task<HiveSection> UpdateHiveSectionAsync(int sectionId, UpdateHiveSectionRequest updateRequest);

        /// <summary>
        /// Creates a hive section.
        /// </summary>
        /// <param name="createRequest">Update object with data.</param>
        /// <returns>Task with hive section.</returns>
        Task<HiveSection> CreateHiveSectionAsync(UpdateHiveSectionRequest createRequest);

        /// <summary>
        /// Gets a list of hive sections.
        /// </summary>
        /// <returns>A <see cref="Task{List{HiveSectionListItem}}"/>.</returns>
        Task<List<HiveSectionListItem>> GetHiveSectionsAsync();

        /// <summary>
        /// Gets a hive section.
        /// </summary>
        /// <param name="id">A hive section identifier.</param>
        /// <returns>A <see cref="Task{HiveSection}"/>.</returns>
        Task<HiveSection> GetHiveSectionAsync(int id);

        /// <summary>
        /// Gets a list of hive sections for specified hive.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <returns>A <see cref="Task{List{HiveSectionListItem}}"/>.</returns>
        Task<List<HiveSectionListItem>> GetHiveSectionsAsync(int hiveId);

        /// <summary>
        /// Sets deleted status for a hive section.
        /// </summary>
        /// <param name="hiveSectionId">A hive section identifier.</param>
        /// <param name="deletedStatus">Status.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task SetStatusAsync(int hiveSectionId, bool deletedStatus);
    }
}
